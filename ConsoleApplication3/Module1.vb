Module Module1

    Sub Main()
        Console.WriteLine("1,5,3中最大的數是{0}", GetMax(1, 5, 3).ToString())
        Console.WriteLine()
        Console.WriteLine("10,5,3,100,23中最大的數是{0}", GetMax(10, 5, 3, 100, 23).TosTring())
        Console.Read()


    End Sub
    Function GetMax(ByVal ParamArray x() As Integer) As Integer
        Dim Max As Integer
        Max = x(0)
        For i As Integer = 1 To x.Length - 1
            If x(i) > Max Then
                Max = x(i)
            End If
        Next
        Return Max

    End Function
End Module
