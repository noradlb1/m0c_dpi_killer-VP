Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Threading
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Namespace m0c_dpi_killer
	Partial Public Class Form1
		Inherits Form

		Public Shared dnscrypt_path, windivert_dll_path, goodbyedpi_path, windivert_sys_path, current_dns As String
		Public Shared dnscrypt_process, goodbyedpi_process As Process
		Public Shared internet_nic As NetworkInterface
		Public Shared cleaned As Boolean=False

		Public Const WM_NCLBUTTONDOWN As Integer = &HA1
		Public Const HT_CAPTION As Integer = &H2

		<DllImportAttribute("user32.dll")> _
		Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
		End Function
		<DllImportAttribute("user32.dll")> _
		Public Shared Function ReleaseCapture() As Boolean
		End Function

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Shared Sub progress(ByVal value As Integer, ByVal myForm As Form1)
			myForm.progressBar1.Value = value
			myForm.Refresh()

		End Sub

		Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			clean(Me)
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			progress(10, Me)
			timer1.Enabled = False
			Dim is64bit As Boolean = Not String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))

			internet_nic = Functions.get_interneet_nic()
			If internet_nic Is Nothing Then
				lblStatus.Text = "Cannot find any internet interface."
				cleaned = True
				Return
			End If
			progress(20, Me)

			current_dns = ""
			For i As Integer = 0 To (internet_nic.GetIPProperties().DnsAddresses.Count) - 1
				current_dns &= internet_nic.GetIPProperties().DnsAddresses(i).ToString() & ","
			Next i
			current_dns = current_dns.Substring(0, current_dns.Length - 1)


			'Run dnscrypt
			dnscrypt_path = Path.Combine(Path.GetTempPath(), "dnscrypt_proxy.exe")
			Try
				File.WriteAllBytes(dnscrypt_path, m0c_dpi_killer.Resource1.dnscrypt_proxy)
			Catch eee As Exception

			End Try
			progress(30, Me)
			dnscrypt_process = Functions.run_process_in_bg(dnscrypt_path)
			progress(40, Me)

			windivert_dll_path = Path.Combine(Path.GetTempPath(), "WinDivert.dll")
			goodbyedpi_path = Path.Combine(Path.GetTempPath(), "goodbyedpi.exe")
			windivert_sys_path = ""
			If is64bit = True Then
				Try
					File.WriteAllBytes(goodbyedpi_path, m0c_dpi_killer.Resource1._64_goodbyedpi)
				Catch ee As Exception

				End Try
				progress(50, Me)

				Try
					File.WriteAllBytes(windivert_dll_path, m0c_dpi_killer.Resource1._64_WinDivert_dll)
				Catch ee As Exception

				End Try
				progress(60, Me)
				windivert_sys_path = Path.Combine(Path.GetTempPath(), "WinDivert64.sys")
				Try
					File.WriteAllBytes(windivert_sys_path, m0c_dpi_killer.Resource1._64_WinDivert64_sys)
				Catch ee As Exception

				End Try
			Else
				Try
					File.WriteAllBytes(goodbyedpi_path, m0c_dpi_killer.Resource1._32_goodbyedpi)
				Catch ee As Exception

				End Try
				progress(50, Me)
				Try
					File.WriteAllBytes(windivert_dll_path, m0c_dpi_killer.Resource1._32_WinDivert_dll)
				Catch ee As Exception

				End Try
				progress(60, Me)
				windivert_sys_path = Path.Combine(Path.GetTempPath(), "WinDivert32.sys")
				Try
					File.WriteAllBytes(windivert_sys_path, m0c_dpi_killer.Resource1._32_WinDivert32_sys)
				Catch ee As Exception

				End Try
			End If
			progress(70, Me)
			Functions.remove_dns(internet_nic)
			progress(75, Me)
			Functions.set_dns(internet_nic, "127.0.0.1")
			progress(80, Me)
			goodbyedpi_process = Functions.run_process_in_bg(goodbyedpi_path)
			progress(85, Me)


			Thread.Sleep(1000)
			progress(90, Me)
			lblStatus.Text = "Enjoy !"
			lblStatus.ForeColor = Color.ForestGreen
			Thread.Sleep(1000)
			progress(100, Me)
			'System.Diagnostics.Process.Start("https://www.youtube.com");

		End Sub

		Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
			Application.Exit()
		End Sub

		Private Sub btnMin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMin.Click
			Me.WindowState= FormWindowState.Minimized
		End Sub

		Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
			If e.Button = MouseButtons.Left Then
				ReleaseCapture()
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
			End If
		End Sub

		Private Sub panel2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panel2.MouseDown
			Form1_MouseDown(sender, e)
		End Sub

		Private Sub label1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles label1.MouseDown
			Form1_MouseDown(sender, e)
		End Sub

		Private Sub label2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles label2.MouseDown
			Form1_MouseDown(sender, e)
		End Sub

		Private Sub panel1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panel1.MouseDown
			Form1_MouseDown(sender, e)
		End Sub

		Private Sub lblStatus_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lblStatus.MouseDown
			Form1_MouseDown(sender, e)
		End Sub

		Private Sub progressBar1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles progressBar1.MouseDown
			Form1_MouseDown(sender, e)
		End Sub

		Private Sub panel3_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panel3.MouseDown
			Form1_MouseDown(sender, e)
		End Sub

		Private Sub label3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label3.Click
			Process.Start("tg://resolve?domain=m0c_dpi_killer")
		End Sub

		Private Sub pictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox1.Click
			Process.Start("tg://resolve?domain=m0c_dpi_killer")
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			progressBar1.ForeColor = Color.FromArgb(56, 105, 129)
			progressBar1.BackColor = Color.FromArgb(41, 44, 51)
		End Sub

		Private Shared Sub clean(ByVal myForm As Form1)
			If cleaned = True Then
				Return
			End If
			cleaned = True
			myForm.lblStatus.ForeColor = Color.SteelBlue
			myForm.lblStatus.Text = "Please wait... Reverting..."
			myForm.Refresh()
			Try
				dnscrypt_process.Kill()
			Catch e As Exception

			End Try
			progress(80, myForm)

			Try
				goodbyedpi_process.Kill()

			Catch e As Exception

			End Try
			progress(60, myForm)

			Thread.Sleep(1000)
			progress(50, myForm)
			Thread.Sleep(1000)
			progress(40, myForm)
			Try
				File.Delete(dnscrypt_path)
			Catch eee As Exception
				Functions.task_kill("dnscrypt_proxy.exe")
				Thread.Sleep(500)
				File.Delete(dnscrypt_path)
			End Try

			progress(30, myForm)
			Try
				File.Delete(goodbyedpi_path)
			Catch eee As Exception
				Functions.task_kill("goodbyedpi.exe")
				Thread.Sleep(500)
				File.Delete(goodbyedpi_path)
			End Try
			progress(20, myForm)

			Functions.remove_dns(internet_nic)
			progress(10, myForm)
			If current_dns.Substring(0, 9) <> "127.0.0.1" Then
				Functions.set_dns(internet_nic, current_dns)
			End If

			progress(0, myForm)
		End Sub
	End Class
End Namespace
