Imports System.Data.SqlClient
Imports System.IO
Public Class Form1
    Dim bag As SqlConnection = New SqlConnection("Server=ISTANBULL;Initial Catalog=tts;Integrated Security=True")

    Public Const _BaseApiURL As String = "https://tts.voicetech.yandex.net/generate?text="
    Public Const _api As String = "&forma0t=0mp3&lang=tr-TR&speaker=zahar&emotion=good&key=358b6df1-6fe8-43bf-8caf-4d38d144ccd7"

    Private Sub spkbtn_Click(sender As Object, e As EventArgs) Handles spkbtn.Click
        Dim deger As String = TextBox1.Text
        Dim _apiURL As String = _BaseApiURL + deger + _api
        mediaPlayer.URL = String.Format(_apiURL, System.Net.WebUtility.UrlEncode(TextBox1.Text.ToString()))
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        'OpenFileDialog1.Title = "ses"
        'OpenFileDialog1.Filter = "mp3 (*.mp3) | .mp3 | wav (*.wav) | .wav"
        'If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

        'Dim sespath As String
        'sespath = OpenFileDialog1.ToString()
        'Dim fs As New FileStream(sespath, FileMode.Open, FileAccess.Read)
        'Dim br As New BinaryReader(fs)
        'Dim bytes As Byte() = br.ReadBytes(CInt(fs.Length))
        'Dim cmd As New SqlCommand("insert into ses(ses) values(@ses)", bag)
        'cmd.Parameters.AddWithValue("@ses", bytes)
        'bag.Open()
        'cmd.ExecuteNonQuery()
        'bag.Close()
    End Sub
End Class
