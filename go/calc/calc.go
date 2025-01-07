package main

import "fmt"

var InitialValue float64

func doCalculate(num float64, op string) float64 {
	switch op {
	case "+":
		InitialValue = InitialValue + num
	case "-":
		InitialValue = InitialValue - num
	case "/":
		InitialValue = InitialValue / num
	case "*":
		InitialValue = InitialValue * num
	default:
		fmt.Println("invalid operator")
	}

	return InitialValue
}
