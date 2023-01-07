Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading.Tasks

Namespace m0c_dpi_killer
	Public NotInheritable Class Functions

		Private Sub New()
		End Sub

		Public Shared Sub run_netsh_command(ByVal command As String)
			Dim pProcess = New Process()
			pProcess.StartInfo.FileName = "netsh.exe"
			pProcess.StartInfo.Arguments = command
			pProcess.StartInfo.UseShellExecute = False
			pProcess.StartInfo.RedirectStandardOutput = True
			pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
			pProcess.StartInfo.CreateNoWindow = True 'not diplay a windows
			pProcess.Start()
			pProcess.WaitForExit(4000)
		End Sub
		Public Shared Function get_interneet_nic() As NetworkInterface
			Dim u As New UdpClient("8.8.8.8", 1)
			Dim localAddr As IPAddress = CType(u.Client.LocalEndPoint, IPEndPoint).Address

			Dim target_nic As NetworkInterface = Nothing
			For Each nic As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()
				Dim ipProps As IPInterfaceProperties = nic.GetIPProperties()

				' check if localAddr is in ipProps.UnicastAddresses
				For j As Integer = 0 To ipProps.UnicastAddresses.Count - 1
					If localAddr.Equals(ipProps.UnicastAddresses(j).Address) Then
						target_nic = nic
						Exit For
					End If
				Next j
			Next nic
			Return target_nic
		End Function
		Public Shared Sub remove_dns(ByVal target_nic As NetworkInterface)
			run_netsh_command("dnsclient delete dnsserver """ & target_nic.Name & """ all")
		End Sub
		Public Shared Sub set_dns(ByVal target_nic As NetworkInterface, ByVal dns_server As String)
			Dim servers() As String = dns_server.Split(","c)

			Dim this_num As Integer
			For i As Integer = 0 To servers.Length - 1
				this_num = i + 1
				run_netsh_command("dnsclient add dnsserver """ & target_nic.Name & """ " & servers(i) & " " & this_num.ToString())
			Next i
		End Sub
		Public Shared Function run_process_in_bg(ByVal path As String) As Process
			Dim pProcess = New Process()
			pProcess.StartInfo.FileName = path
			pProcess.StartInfo.UseShellExecute = False
			pProcess.StartInfo.RedirectStandardOutput = True
			pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
			pProcess.StartInfo.CreateNoWindow = True 'not diplay a windows
			pProcess.Start()
			Return pProcess
		End Function
		Public Shared Sub task_kill(ByVal exe_name As String)
			Dim pProcess = New Process()
			pProcess.StartInfo.FileName = "cmd.exe"
			pProcess.StartInfo.Arguments = "/c taskkill /F /IM " & exe_name & " /T"
			pProcess.StartInfo.UseShellExecute = False
			pProcess.StartInfo.RedirectStandardOutput = True
			pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
			pProcess.StartInfo.CreateNoWindow = True 'not diplay a windows
			pProcess.Start()
			pProcess.WaitForExit(4000)
		End Sub

	End Class
End Namespace
