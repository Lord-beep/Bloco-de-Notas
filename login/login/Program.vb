Imports System.IO

Module Module1
    Sub Main()
        Console.Write("Login:> ")
        Dim strlogin As String = Console.ReadLine
        Console.Write("Senha:> ")
        Dim strsenha As String = Console.ReadLine
        If Len(strlogin) > 0 And Len(strsenha) > 0 Then
            Try
                'Dim bw as New BinaryWriter (New FileStream ("user.dat", Filemode.create))
                Dim bw As New StreamWriter(New FileStream("user.txt", FileMode.Create))
                Try
                    bw.Write(strlogin)
                    bw.Write(";")
                    bw.Write(strsenha)
                    bw.Write(";")

                Catch ex As Exception
                    Console.WriteLine("Erro na escrita." & vbNewLine & ex.Message)
                End Try
                bw.Close()
            Catch ex As Exception
                Console.WriteLine("Erro ao criar o ficheiro!" & vbNewLine & ex.Message)
            End Try
        End If
        Console.Read()
    End Sub
End Module
