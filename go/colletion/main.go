package main

import "fmt"

func main() {
	addItem("Key1", "value1")
	addItem("Key2", "value2")
	updateItem("Key2", "SomeValue")
	addItem("Key3", "value3")
	result := getById("Key3")
	fmt.Println(result)
	getAll()
	deleteItem("Key2")
	getAll()

}
