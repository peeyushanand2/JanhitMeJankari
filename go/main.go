package main // compiles into executables

import (
	"fmt"
)

const FName string = "Peeyush"

var Lastneme string = "anand"

func main() { // entry point to the executable
	var fname, lname string = "peeyush", "anand"
	tst, tt := "test", "entry"
	var age int
	age = 40
	fmt.Println(fname, lname)
	fmt.Println(tst, tt)
	fmt.Println(FName, Lastneme)
	fmt.Println(age)
}
