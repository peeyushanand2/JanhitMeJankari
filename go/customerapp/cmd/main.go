package main

// Implement other methods for the type CustomerController
import (
	"customerapp/controller"
	"customerapp/memstore"
	"log"
	"net/http"
)

// Inside the main function
func main() {

	repo := memstore.NewCustomerRepository() // With in-memory database

	h := &controller.CustController{
		Repository: repo, // Injecting dependency
	}
	router := initializeRoutes(h) // configure routes
	// CORS middleware
	//router = cors.Default().Handler(router)
	server := &http.Server{
		Addr:    ":8080",
		Handler: router,
	}
	log.Println("Listening...")
	server.ListenAndServe() // Run the http server
	// controller := controller.CustController{ // initialize customer controller
	// 	Repository: memstore.NewCustomerRepository(),
	// 	//Repository: mongodb.NewCustomerRepository(), // switching to another persistent store
	// }
	// var data []domain.Customer
	// data = make([]domain.Customer, 0, 4)
	// data = append(data, domain.Customer{
	// 	ID:    "cust101",
	// 	Name:  "Rahul",
	// 	Email: "rahul@gmail.com",
	// })
	// data = append(data, domain.Customer{
	// 	ID:    "cust102",
	// 	Name:  "Rahul2",
	// 	Email: "rahul2@gmail.com",
	// })
	// data = append(data, domain.Customer{
	// 	ID:    "cust103",
	// 	Name:  "Rahul3",
	// 	Email: "rahul3@gmail.com",
	// })
	// for _, v := range data {
	// 	controller.Add(v)
	// }
	// newCustomer := domain.Customer{
	// 	ID:    "cust100",
	// 	Name:  "Rahulnew",
	// 	Email: "rahulnew@gmail.com",
	// }
	// controller.Update("cust103", newCustomer)

	// controller.Delete("cust105")

	// controller.FetchById("cust101")

	// controller.FetchAll()

}
func initializeRoutes(h *controller.CustController) http.Handler {
	mux := http.NewServeMux()
	mux.HandleFunc("GET /api/customers", h.GetAllCustomers)
	mux.HandleFunc("GET /api/customers/{id}", h.GetCustomerById)
	mux.HandleFunc("POST /api/customers", h.CreateNewCustomer)
	mux.HandleFunc("PUT /api/customers/{id}", h.UpdateCustomer)
	mux.HandleFunc("DELETE /api/customers/{id}", h.DeleteCustomer)
	return mux
}
