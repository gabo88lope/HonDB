Imports Microsoft.Office.Interop

Public Class ExportarExcel

    Public Shared Sub EExcel(ByVal obj As Object)

        Dim rt, ct As Short
        Dim i, j, k As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim xlApp As New Excel.Application
        Try
            Dim eb As Excel.Workbook = xlApp.Workbooks.Add
            Dim ew As Excel.Worksheet = CType(eb.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rt = obj.RowCount
            ct = obj.Columns.Count - 1
            With ew
                .Cells.Select()
                .Cells.Delete()
                For k = 0 To ct
                    .Cells(1, k + 1).Value = obj.Columns(k).HeaderText
                Next
                For i = 0 To rt - 1
                    For j = 0 To ct
                        .Cells(i + 2, j + 1).value = obj.Rows(i).Cells(j).Value
                    Next j
                Next i
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.EntireColumn.AutoFit()
            End With
        Catch ex As Exception
            EMsg.Show("Error al exportar a Microsoft Excel", ex)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

End Class
