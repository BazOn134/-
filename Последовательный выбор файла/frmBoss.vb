Public Class frmBoss
    Private Sub ToolStripButtonSettings_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSettings.Click
        Dim frmSett As New frmSettings
        frmSett.Show()
    End Sub

    Private Sub ToolStripButtonAbout_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAbout.Click
        Dim formAbout As New frmAbout
        formAbout.Show()
    End Sub

    Private Sub ХххToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ХххToolStripMenuItem.Click
        ListBox1.Items.Add("11111111111110000000000000000000000011111111111111111111110000000000000000000000000000")
        ListBox1.Items.Add("2")
        ListBox1.Items.Add("11111111111110000000000000000000000011111111111111111111110000000000000000000000000000")
        ListBox1.Items.Add("2")
        ListBox1.Items.Add("11111111111110000000000000000000000011111111111111111111110000000000000000000000000000")
        ListBox1.Items.Add("2")
        MessageBox.Show(ListBox1.Items.Count)
        If ListBox1.Items.Count > 10 Then ListBox1.Items.Add("1111111111111000000000000000000000001111111111111111111111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000")
        SetListBoxAutoSize(ListBox1)
    End Sub

    Private Sub frmBoss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("1")
        ListBox1.Items.Add("2")
        SetListBoxAutoSize(ListBox1)
    End Sub

    Public Sub SetListBoxAutoSize(listBox As ListBox)
        If listBox.Items.Count = 0 Then Exit Sub
        Dim itemBigWidth As String = String.Empty
        Dim EndWidth As Integer = -1
        For Each item As String In listBox.Items
            If item.Length > EndWidth Then itemBigWidth = item : EndWidth = item.Length
        Next
        Dim TSize As Size = TextRenderer.MeasureText(itemBigWidth, listBox.Font)
        Dim TWidth = TSize.Width + 4 : If TWidth < 300 Then TWidth = 300
        Dim THeight = TSize.Height * (listBox.Items.Count + 1) : If THeight < 100 Then THeight = 100
        Dim FWidth = TWidth + 16
        Dim FHeight = THeight + 122
        Me.Size = New Size(FWidth, FHeight)
        listBox.Size = New Size(TWidth, THeight)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        MessageBox.Show(ListBox1.SelectedItem.ToString)
    End Sub
End Class
