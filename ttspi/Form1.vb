Public Class Form1

    Public Const _BaseApiURL As String = "https://tts.voicetech.yandex.net/generate?text="
    Public Const _api As String = "&forma0t=0mp3&lang=tr-TR&speaker=zahar&emotion=good&key=358b6df1-6fe8-43bf-8caf-4d38d144ccd7"

    Private Sub spkbtn_Click(sender As Object, e As EventArgs) Handles spkbtn.Click
        Dim deger As String = TextBox1.Text
        Dim _apiURL As String = _BaseApiURL + deger + _api
        mediaPlayer.URL = String.Format(_apiURL, System.Net.WebUtility.UrlEncode(TextBox1.Text.ToString()))
    End Sub
End Class
