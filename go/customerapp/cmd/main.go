package main

// Implement other methods for the type CustomerController
import (
	"customerapp/domain"
	"customerapp/memstore"
)

// Inside the main function
func main() {
	controller := CustomerController{ // initialize customer controller
		repository: memstore.NewCustomerRepository(),
		//repository: mongodb.NewCustomerRepository(), // switching to another persistent store
	}
	var data []domain.Customer
	data = make([]domain.Customer, 0, 4)
	data = append(data, domain.Customer{
		ID:    "cust101",
		Name:  "Rahul",
		Email: "rahul@gmail.com",
	})
	data = append(data, domain.Customer{
		ID:    "cust102",
		Name:  "Rahul2",
		Email: "rahul2@gmail.com",
	})
	data = append(data, domain.Customer{
		ID:    "cust103",
		Name:  "Rahul3",
		Email: "rahul3@gmail.com",
	})
	for _, v := range data {
		controller.Add(v)
	}
	newCustomer := domain.Customer{
		ID:    "cust100",
		Name:  "Rahulnew",
		Email: "rahulnew@gmail.com",
	}
	controller.Update("cust103", newCustomer)

	controller.Delete("cust105")

	controller.FetchById("cust101")

	controller.FetchAll()

}
