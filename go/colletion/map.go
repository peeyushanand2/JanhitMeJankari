package main

import "fmt"

var data map[string]string //nil map

func init() {
	data = make(map[string]string) //map initialized
}

func addItem(key, value string) {
	if _, exist := data[key]; exist {

		fmt.Println("key exist")
		return
	}
	data[key] = value
	fmt.Println("data inserted")
}
func updateItem(key, value string) {
	if _, exist := data[key]; !exist {

		fmt.Println("key not exist")
		return
	}
	data[key] = value
	fmt.Println("data updated")
}
func getById(key string) string {
	if _, exist := data[key]; !exist {

		fmt.Println("data does not exist for %d", key)
	}

	return data[key]
}

func getAll() {
	for k, v := range data {
		fmt.Printf("Key: %s Value: %s\n", k, v)
	}
}

func deleteItem(key string) {
	if _, exist := data[key]; !exist {
		fmt.Println("key not exist")
		return
	}

	delete(data, key)
	fmt.Println("data deleted for", key)

}
