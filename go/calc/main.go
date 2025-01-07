package main

import "fmt"

func main() {

	var result float64
	result = doCalculate(100, "+") // result => 100
	fmt.Println(result)
	result = doCalculate(50, "-") // result => 50
	fmt.Println(result)
	result = doCalculate(20, "/") // result => 2.5
	fmt.Println(result)
	result = doCalculate(10, "*") // result => 25
	fmt.Println(result)
}
