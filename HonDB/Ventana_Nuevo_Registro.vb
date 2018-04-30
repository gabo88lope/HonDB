Imports MySql.Data.MySqlClient
Public Class Ventana_Nuevo_Registro

    Private Sub BTCancelar_Click(sender As Object, e As EventArgs) Handles BTCancelar.Click
        Me.Close()

    End Sub

    Private Sub TBNS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNS.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TBAU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBAU.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TBNac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNac.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TBNB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNB.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TBISBN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBISBN.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBoxEP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEP.SelectedIndexChanged
        PopulateCombobox(ComboBoxEP, "prestamo", "estado")
    End Sub

    Private Sub BTGuardar_Click(sender As Object, e As EventArgs) Handles BTGuardar.Click
        Dim Agregar As String
        Agregar = "INSERT INTO usuario (nombre, apellido, identificacion, idubicacion)
        VALUES ('" & TBNS.Text & "','" & TBAU.Text & "','" & TBID.Text & "')"
        SaveData(Agregar)
    End Sub

    Private Sub Ventana_Nuevo_Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class