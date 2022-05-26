Public Class Programar_Comportamento
    Dim tempo As Double
    Dim tempoTimer As Double
    Private Sub definirTempo()
        tempo = numHoras.Value * 3600
        lblTempo.Text = tempo
    End Sub
    Private Sub contagemRegressiva()
        Dim _contagem As Double
        _contagem = tempo - tempoTimer
        lblFaltam.Text = _contagem
    End Sub
    Private Sub limpar()
        lblContagem.Text = 0
        lblFaltam.Text = 0
        lblTempo.Text = 0
        numHoras.Value = 0
        tempoTimer = 0
    End Sub
    Private Sub btnDesligar_Click(sender As Object, e As EventArgs) Handles btnDesligar.Click
        Try
            definirTempo()
            Dim _tempo As String = tempo
            Shell("shutdown -s -t " + _tempo)
            Dim horas As String = tempo / 3600
            MsgBox("Desligamento agendado para daqui a " + horas + " horas")
            timerDesligar.Start()

        Catch ex As Exception
            MsgBox("Erro:" + ex.Message)
        End Try
    End Sub

    Private Sub btnHibernar_Click(sender As Object, e As EventArgs) Handles btnHibernar.Click
        Try
            definirTempo()
            timerHibernar.Start()
            Dim horas As String = tempo / 3600
            MsgBox("Hibernando daqui a " + horas + " horas")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub selectCaseMetodo()
        If tempo <> 0 Then
            Select Case tempoTimer

                Case < tempo

                Case = tempo
                    timerHibernar.Stop()
                    timerHibernar.Enabled = False
                    Shell("shutdown -h")
                    MsgBox("tempo alcançado!" + lblContagem.Text)


                Case Else
                    MsgBox("Falha no loop")
                    timerHibernar.Stop()
                    timerHibernar.Enabled = False
            End Select
        ElseIf tempo = 0 Then
            timerHibernar.Stop()
            timerHibernar.Enabled = False
            Shell("shutdown -h")
            MsgBox("Hibernando agora!")
        End If

    End Sub
    Private Sub timerHibernar_Tick(sender As Object, e As EventArgs) Handles timerHibernar.Tick
        tempoTimer += 1
        lblContagem.Text = tempoTimer
        selectCaseMetodo()
        contagemRegressiva()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        definirTempo()
        If tempo > 0 Then
            timerHibernar.Start()
            tempo = numHoras.Text
        Else
            timerHibernar.Stop()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        timerHibernar.Stop()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Shell("shutdown -a")
            MsgBox("Cancelado com sucesso!")
            tempo = 0
            timerHibernar.Stop()
            limpar()
            timerDesligar.Stop()
            timerDesligar.Stop()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub timerDesligar_Tick(sender As Object, e As EventArgs) Handles timerDesligar.Tick
        tempoTimer += 1
        lblContagem.Text = tempoTimer
        contagemRegressiva()
    End Sub
End Class
