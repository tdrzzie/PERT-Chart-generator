Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtCodeA.Text = "" Or txtTestA.Text = "" Or txtCodeB.Text = "" Or txtTestB.Text = "" Or txtCodeC.Text = "" Or txtTestC.Text = "" Or txtCompleteTest.Text = "" Then
            MsgBox("Please input number of days")
        Else
            lblDCodeA.Text = txtCodeA.Text + ("Days")
            lblDTestA.Text = txtTestA.Text + ("Days")
            lblDCodeB.Text = txtCodeB.Text + ("Days")
            lblDTestB.Text = txtTestB.Text + ("Days")
            lblDCodeC.Text = txtCodeC.Text + ("Days")
            lblDTestC.Text = txtTestC.Text + ("Days")
            lblDCompleteTest.Text = txtCompleteTest.Text + ("Days")
            lblCodeA.Visible = True
            lblDCodeA.Visible = True
            lblTestA.Visible = True
            lblDTestA.Visible = True
            lblCodeB.Visible = True
            lblDCodeB.Visible = True
            lblTestB.Visible = True
            lblDTestB.Visible = True
            lblCodeC.Visible = True
            lblDCodeC.Visible = True
            lblTestC.Visible = True
            lblDTestC.Visible = True
            lblCompleteTest.Visible = True
            lblDCompleteTest.Visible = True
            lblCriticalPath.Visible = True
            lynCodeA.Visible = True
            lynCodeAA.Visible = True
            lynTestA.Visible = True
            lynTestAA.Visible = True
            lynCodeB.Visible = True
            lynTestB.Visible = True
            lynCodeC.Visible = True
            lynCodeCC.Visible = True
            lynTestC.Visible = True
            lynTestCC.Visible = True
            lynCompleteTest.Visible = True
            lynCriticalPath.Visible = True
            OvalShape1.Visible = True
            OvalShape2.Visible = True
            OvalShape3.Visible = True
            OvalShape4.Visible = True
            OvalShape5.Visible = True
            OvalShape6.Visible = True
            If txtCodeA.Text + txtTestA.Text > txtCodeB.Text + txtTestB.Text And txtCodeA.Text + txtTestA.Text > txtCodeC.Text + txtTestC.Text Then
                lynCodeA.BorderColor = Color.Red
                lynCodeA.BorderWidth = 3
                lynCodeAA.BorderColor = Color.Red
                lynCodeAA.BorderWidth = 3
                lynTestA.BorderColor = Color.Red
                lynTestA.BorderWidth = 3
                lynTestAA.BorderColor = Color.Red
                lynTestAA.BorderWidth = 3
                lynCodeB.BorderColor = Color.Black
                lynCodeB.BorderWidth = 2
                lynTestB.BorderColor = Color.Black
                lynTestB.BorderWidth = 2
                lynCodeC.BorderColor = Color.Black
                lynCodeC.BorderWidth = 2
                lynCodeCC.BorderColor = Color.Black
                lynCodeCC.BorderWidth = 2
                lynTestC.BorderColor = Color.Black
                lynTestC.BorderWidth = 2
                lynTestCC.BorderColor = Color.Black
                lynTestCC.BorderWidth = 2
                lynCompleteTest.BorderColor = Color.Red
                lynCompleteTest.BorderWidth = 3
            ElseIf txtCodeB.Text + txtTestB.Text > txtCodeA.Text + txtTestA.Text And txtCodeB.Text + txtTestB.Text > txtCodeC.Text + txtTestC.Text Then
                lynCodeA.BorderColor = Color.Black
                lynCodeA.BorderWidth = 2
                lynCodeAA.BorderColor = Color.Black
                lynCodeAA.BorderWidth = 2
                lynTestA.BorderColor = Color.Black
                lynTestA.BorderWidth = 2
                lynTestAA.BorderColor = Color.Black
                lynTestAA.BorderWidth = 2
                lynCodeB.BorderColor = Color.Red
                lynCodeB.BorderWidth = 3
                lynTestB.BorderColor = Color.Red
                lynTestB.BorderWidth = 3
                lynCodeC.BorderColor = Color.Black
                lynCodeC.BorderWidth = 2
                lynCodeCC.BorderColor = Color.Black
                lynCodeCC.BorderWidth = 2
                lynTestC.BorderColor = Color.Black
                lynTestC.BorderWidth = 2
                lynTestCC.BorderColor = Color.Black
                lynTestCC.BorderWidth = 2
                lynCompleteTest.BorderColor = Color.Red
                lynCompleteTest.BorderWidth = 3
            ElseIf txtCodeC.Text + txtTestC.Text > txtCodeA.Text + txtTestA.Text And txtCodeC.Text + txtTestC.Text > txtCodeB.Text + txtTestB.Text Then
                lynCodeA.BorderColor = Color.Black
                lynCodeA.BorderWidth = 2
                lynCodeAA.BorderColor = Color.Black
                lynCodeAA.BorderWidth = 2
                lynTestA.BorderColor = Color.Black
                lynTestA.BorderWidth = 2
                lynTestAA.BorderColor = Color.Black
                lynTestAA.BorderWidth = 2
                lynCodeB.BorderColor = Color.Black
                lynCodeB.BorderWidth = 2
                lynTestB.BorderColor = Color.Black
                lynTestB.BorderWidth = 2
                lynCodeC.BorderColor = Color.Red
                lynCodeC.BorderWidth = 3
                lynCodeCC.BorderColor = Color.Red
                lynCodeCC.BorderWidth = 3
                lynTestC.BorderColor = Color.Red
                lynTestC.BorderWidth = 3
                lynTestCC.BorderColor = Color.Red
                lynTestCC.BorderWidth = 3
                lynCompleteTest.BorderColor = Color.Red
                lynCompleteTest.BorderWidth = 3
            End If
        End If

    End Sub
End Class
