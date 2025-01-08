package main

import (
	"customerapp/domain"
	"fmt"
)

// CustomerController Organises the CRUD operations at UI layer.
type CustomerController struct {
	repository domain.CustomerRepository
}

// Add function to add new customer.
func (cc CustomerController) Add(c domain.Customer) {
	fmt.Println("Add operation")
	err := cc.repository.Create(c)
	if err != nil {
		fmt.Println("Error: ", err)
		return
	}
	fmt.Println("new Customer has been created")
	fmt.Println("-----------------------")
}

func (cc CustomerController) Update(id string, c domain.Customer) {
	fmt.Println("Update operation")
	err := cc.repository.Update(id, c)
	if err != nil {
		fmt.Println("Error: ", err)
		return
	}
	fmt.Println("new Customer has been updated")
	fmt.Println("-----------------------")
}

func (cc CustomerController) Delete(id string) {
	fmt.Println("Delete operation")
	err := cc.repository.Delete(id)
	if err != nil {
		fmt.Println("Error: ", err)
		return
	}
	fmt.Println("new customer has been deleted")
	fmt.Println("-----------------------")
}
func (cc CustomerController) FetchById(id string) {
	fmt.Println("FetchById operation")
	data, err := cc.repository.GetById(id)
	if err != nil {
		fmt.Println("Error: ", err)
		return
	}

	fmt.Println("ID:", data.ID)
	fmt.Println("Name:", data.Name)
	fmt.Println("ID:", data.Email)
	fmt.Println("-----------------------")
}
func (cc CustomerController) FetchAll() {
	fmt.Println("FetchAll operation")
	data, err := cc.repository.GetAll()
	if err != nil {
		fmt.Println("Error: ", err)
		return
	}
	for _, v := range data {
		fmt.Println(v.ID)
		fmt.Println(v.Name)
		fmt.Println(v.Email)
		fmt.Println("-----------------------")
	}
}
