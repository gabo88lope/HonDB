﻿Imports System
Imports System.IO
Imports System.Security.Cryptography

Module Encriptacion

    Private enc As System.Text.UTF8Encoding
    Private encryptor As ICryptoTransform
    Private decryptor As ICryptoTransform

    Private Sub Load()
        Dim KEY_128 As Byte() = {42, 1, 52, 67, 231, 13, 94, 101, 123, 6, 0, 12, 32, 91, 4, 111, 31, 70, 21, 141, 123, 142, 234, 82, 95, 129, 187, 162, 12, 55, 98, 23}
        Dim IV_128 As Byte() = {234, 12, 52, 44, 214, 222, 200, 109, 2, 98, 45, 76, 88, 53, 23, 78}
        Dim symmetricKey As RijndaelManaged = New RijndaelManaged()
        symmetricKey.Mode = CipherMode.CBC

        enc = New System.Text.UTF8Encoding
        encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128)
        decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128)
    End Sub

    Public Function Encriptar(ByVal s As String) As String

        Load()
        Dim sPlainText As String = s

        If Not String.IsNullOrEmpty(sPlainText) Then
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)
            cryptoStream.Write(enc.GetBytes(sPlainText), 0, sPlainText.Length)
            cryptoStream.FlushFinalBlock()
            Return Convert.ToBase64String(memoryStream.ToArray())
            memoryStream.Close()
            cryptoStream.Close()
        Else
            Return Nothing
        End If
    End Function

    Public Function Desencriptar(ByVal s As String) As String

        Load()
        Dim cypherTextBytes As Byte() = Convert.FromBase64String(s)
        Dim memoryStream As MemoryStream = New MemoryStream(cypherTextBytes)
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)
        Dim plainTextBytes(cypherTextBytes.Length) As Byte
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
        memoryStream.Close()
        cryptoStream.Close()
        Return enc.GetString(plainTextBytes, 0, decryptedByteCount)

    End Function

End Module
