Public Class Form1
    Private Sub BFuncion_Click(sender As Object, e As EventArgs) Handles BFuncion.Click
        Dim desde As Integer = Val(TDesde.Text)
        Dim hasta As Integer = Val(THasta.Text)
        ListBox1.Items.Clear()
        TDesde.Focus()

        If String.IsNullOrWhiteSpace(TDesde.Text) Or String.IsNullOrWhiteSpace(THasta.Text) Then
            MsgBox("Debe Completar todos los campos", vbCritical, "Error")
        Else
            If (desde <= hasta) Then
                While (desde <= hasta)
                    ListBox1.Items.Add(desde)
                    desde = desde + 1
                End While
            Else
                MsgBox("La secuencia de número ingresada es incorrecta", vbCritical, "Error")
            End If
        End If

    End Sub
    Private Sub BPares_Click(sender As Object, e As EventArgs) Handles BPares.Click
        If String.IsNullOrWhiteSpace(TDesde.Text) Or String.IsNullOrWhiteSpace(THasta.Text) Then
            MsgBox("Debe Completar todos los campos", vbCritical, "Error")
        Else
            Dim desde As Integer = TDesde.Text
            Dim hasta As Integer = THasta.Text
            TDesde.Focus()
            ListBox1.Items.Clear()

            If (desde <= hasta) Then
                For i As Integer = desde To hasta Step +1
                    If (i Mod 2 = 0) Then
                        ListBox1.Items.Add(i)
                    End If
                Next
            Else
                MsgBox("La secuencia de número ingresada es incorrecta", vbCritical, "Error")
            End If
        End If

    End Sub
    Private Sub BImpares_Click(sender As Object, e As EventArgs) Handles BImpares.Click
        If String.IsNullOrWhiteSpace(TDesde.Text) Or String.IsNullOrWhiteSpace(THasta.Text) Then
            MsgBox("Debe Completar todos los campos", vbCritical, "Error")
        Else
            Dim desde As Integer = TDesde.Text
            Dim hasta As Integer = THasta.Text
            TDesde.Focus()
            ListBox1.Items.Clear()

            If (desde <= hasta) Then
                For i As Integer = desde To hasta Step +1
                    If (i Mod 2 <> 0) Then
                        ListBox1.Items.Add(i)
                    End If
                Next
            Else
                MsgBox("La secuencia de número ingresada es incorrecta", vbCritical, "Error")
            End If
        End If

    End Sub

    Private Sub BPrimos_Click(sender As Object, e As EventArgs) Handles BPrimos.Click
        If String.IsNullOrWhiteSpace(TDesde.Text) Or String.IsNullOrWhiteSpace(THasta.Text) Then
            MsgBox("Debe Completar todos los campos", vbCritical, "Error")
        Else
            Dim desde As Integer = Integer.Parse(TDesde.Text)
            Dim hasta As Integer = Integer.Parse(THasta.Text)
            TDesde.Focus()
            ListBox1.Items.Clear()

            If (desde <= hasta) Then
                For i As Integer = desde To hasta
                    If EsPrimo(i) Then
                        ListBox1.Items.Add(i)
                    End If
                Next
            Else
                MsgBox("La secuencia de número ingresada es incorrecta", vbCritical, "Error")
            End If
        End If
    End Sub

    Private Function EsPrimo(numero As Integer) As Boolean
        If numero <= 1 Then
            Return False
        End If

        If numero <= 3 Then
            Return True
        End If

        If numero Mod 2 = 0 Or numero Mod 3 = 0 Then
            Return False
        End If

        Dim i As Integer = 5
        While i * i <= numero
            If numero Mod i = 0 Or numero Mod (i + 2) = 0 Then
                Return False
            End If
            i += 6
        End While

        Return True
    End Function

    Private Sub TDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDesde.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True

            MsgBox("Solo se aceptan caracteres númericos", vbCritical)
        End If

    End Sub

    Private Sub THasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles THasta.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True

            MsgBox("Solo se aceptan caracteres númericos", vbCritical)
        End If

    End Sub


End Class
