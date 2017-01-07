Public Class frmState
    'ATTENTION - ATENÇÃO:
    ' Go to Properties in "waStateMachine" - Vá em Properties em "waStateMachine" (Alt+Enter)
    '- Flap - Aba: Application / Option - Opção: ShutDown mode:
    '- Change - Troque:
    '           From - De: "When startup form closes"
    '           To - Para: "When last form closes"

    Dim State As Integer
    ' State = 0 - Idle - Ocioso
    ' State = 1 - Loading existing value - Carregando um valor existente
    ' State = 2 - Adding 1 to existing value - Adicionando 1 a um valor existente
    ' State = 3 - Storing existing value - Armazenando um valor existente
    ' State = 4 - Extra delay - Atraso extra

    Dim Accumulator As Long
    Const OtherCodeDelay = 10
    Public clsT As New clsState()

    Private Sub btnLaunch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaunch.Click
        Dim f As New frmState

        Randomize()
        clsT.pClone = Strings.Right$(Me.Text, Len(Me.Text) - InStrRev(Me.Text, " "))
        clsT.ContaClone += 1

        f.Top = CInt(f.Top - (2500 + Rnd() * 5000))
        f.Left = CInt(f.Left - (2500 + Rnd() * 5000))

        'This the VB6 does not have...
        'Isto o VB6 não tem...
        f.ShowIcon = False
        f.ShowInTaskbar = False

        'In VB6 the "Show" is make after, becouse exist one inversion: To Click the button in VB6, the button play AFTER the Load!
        'No VB6 o "Show" é feito depois, pois existe uma inversão: Ao Clicar o botão no VB6 o botão roda ANTES do Load!
        'I have this same sample in VB6.
        'Tenho este mesmo exemplo em VB6.
        f.Show()

        If clsT.pClone.Length <= 2 Then
            'Original copy
            f.Text = "Cópia do Original: " & clsT.pClone & " - Clone: " & clsT.pClone & "." & clsT.ContaClone
        Else
            'Copy of clone
            f.Text = "Cópia do Clone: " & clsT.pClone & " - Clone: " & clsT.pClone & "." & clsT.ContaClone
        End If

    End Sub

    Private Sub frmMTDemo1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Original form
        Me.Text = "Formulário Original: 0" ' & clsT.pOriginalClone
        'No exist the efect "Randomize", for it will always be the first time the value: "1103".
        'Não está no efeito "Randomize", por isto será sempre na primeira vez o valor: "1103".
        tmrMultiThread.Interval = CInt(750 + Rnd() * 500)
    End Sub

    Private Sub tmrMultiThread_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMultiThread.Tick
        Static otherdelay&

        Select Case State
            Case 0
                lblOperation.Text = "Idle - Ocioso"
                State = 1
            Case 1
                lblOperation.Text = "Loading Acc - Carregando"
                Accumulator = clsT.GenericGlobalCounter
                State = 2
            Case 2
                lblOperation.Text = "Incrementing - Incrementando"
                Accumulator += 1
                State = 3
            Case 3
                lblOperation.Text = "Storing - Armazenando"
                clsT.GenericGlobalCounter = Accumulator
                clsT.TotalIncrements += 1
                State = 4
            Case 4
                lblOperation.Text = "Generic Code - Código Genérico"

                If otherdelay >= OtherCodeDelay Then
                    State = 0
                    otherdelay = 0
                Else
                    otherdelay += 1
                End If

        End Select

        UpdateDisplay()
    End Sub

    Public Sub UpdateDisplay()
        lblGlobalCounter.Text = Str$(clsT.GenericGlobalCounter)

        lblAccumulator.Text = Str$(Accumulator)

        lblVerification.Text = Str$(clsT.TotalIncrements)
    End Sub

End Class
