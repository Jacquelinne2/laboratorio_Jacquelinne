Imports System

Module Program
	Sub Main()
		Console.Title = "Jacquelinne"

		Dim num1, num2 As Integer
		Console.WriteLine("Ingresa un valor:")
		num1 = Console.ReadLine()

		Console.WriteLine("Ingresa un segundo valor:")
		num2 = Console.ReadLine()

		Dim opcion As Integer
		Console.WriteLine("1---- realizar suma")
		Console.WriteLine("2---- realizar resta")
		Console.WriteLine("3---- realizar multiplicacion")
		Console.WriteLine("4---- realizar division")
		opcion = Console.ReadLine

		If (opcion = 1) Then
			Dim suma As Integer
			suma = num1 + num2
			Console.WriteLine("El valor de la suma es: " & suma)


		ElseIf (opcion = 2) Then
			Dim resta As Integer
			resta = num1 - num2
			Console.WriteLine("El valor de la resta: " & resta)

		ElseIf (opcion = 3) Then
			Dim multi As Integer
			multi = num1 * num2
			Console.WriteLine("El valor de multiplicacion: " & multi)

		ElseIf (opcion = 4) Then
			Dim div As Integer
			div = num1 / num2
			Console.WriteLine("El valor de la division: " & div)

		End If

		Console.ReadKey()




	End Sub
End Module
