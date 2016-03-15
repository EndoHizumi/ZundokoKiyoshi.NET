Module Module1

    Dim zundokoParts As String() = {"ズン", "ドコ"}
    Dim Zundoko As String() = {zundokoParts(0), zundokoParts(0), zundokoParts(0), zundokoParts(0), zundokoParts(1)}
    Dim generateList(4) As String
    Dim sleep As Integer = 25
    Sub Main()
        Do

            For i = 0 To Zundoko.Length - 1

                Dim seed As Integer = System.Environment.TickCount '固定じゃない数値をシード値に使う
                Dim rnd As Random = New Random(seed + 1)
                Dim rndNum As Integer = rnd.Next(zundokoParts.Length)
                generateList(i) = zundokoParts(rndNum)
                Console.WriteLine(zundokoParts(rndNum))
                System.Threading.Thread.Sleep(sleep) '連続生成したRandomクラスのシード値の重複防止

            Next
            Console.WriteLine()

        Loop While (compareList() = False)
        Console.WriteLine("キ・ヨ・シ！")

    End Sub

    Function compareList()
        Dim result As Boolean = False
        For i = 0 To Zundoko.Length - 1

            result = Zundoko(i).Equals(generateList(i))
            If (result = False) Then
                Exit For
            End If

        Next
        Return result
    End Function

End Module
