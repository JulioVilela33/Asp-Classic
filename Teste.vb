Public Class Form1
        
        Dim _Teste As New List(Of Teste) From {
            New Teste With
            {.ID = (Int(Rnd * 10) + 1), .Valor = "Teste1", },
            New Tese With
            {.ID = (Int(Rnd * 10) + 1), .Valor = "Teste2",}
            },
            New Tese With
            {.ID = (Int(Rnd * 10) + 1), .Valor = "Teste3",}
            },
            New Tese With
            {.ID = (Int(Rnd * 10) + 1), .Valor = "Teste4",}
            },
            New Tese With
            {.ID = (Int(Rnd * 10) + 1), .Valor = "Teste5",}
        }

        Dim htmlContent As String =
            <html>
                <style type="text/css">     
                TD {background-color: green;color: #F0F8FF;padding-right:15px;}
                .THeader {background-color: Yellow;color: Black;}
            </style>
                <body>
                    <table border="0">
                        <tr>
                            <td class='THeader'>ID</td>
                            <td class='THeader'>Valor</td>
                        </tr>
                        <%= From i In _Teste Select
                            <tr>
                                <td width="80px"><%= i.ID %></td>
                                <td width="45px"><%= i.Valor %></td
                            </tr> %>
                    </table>
                </body>
            </html>.ToString

    End Sub
End Class


Public Class Teste
    
    Public Property ID As Integer 
    Public Property Valor As String
    
    End Sub
 
End Class