Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace System.Windows.Forms
	Friend Class ProgressBarEx
		Inherits ProgressBar

		Public Sub New()
			Me.SetStyle(ControlStyles.UserPaint, True)
		End Sub

		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			Dim brush As LinearGradientBrush = Nothing
			Dim rec As New Rectangle(0, 0, Me.Width, Me.Height)
			Dim scaleFactor As Double = ((CDbl(Value) - CDbl(Minimum)) / (CDbl(Maximum) - CDbl(Minimum)))

			If ProgressBarRenderer.IsSupported Then
				ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec)
			End If

			rec.Width = CInt(Math.Truncate((rec.Width * scaleFactor) - 4))
			rec.Height -= 4
			brush = New LinearGradientBrush(rec, Me.ForeColor, Me.BackColor, LinearGradientMode.Vertical)
			e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height)
		End Sub
	End Class
End Namespace



