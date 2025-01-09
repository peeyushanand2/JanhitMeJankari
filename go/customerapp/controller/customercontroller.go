package controller

import (
	"encoding/json"
	"errors"
	"fmt"
	"net/http"

	"customerapp/domain"
)

// CustController Organises the CRUD operations at UI layer.
type CustController struct {
	Repository domain.CustomerRepository
}

//rest API endpoint available at /api/customers

func (cc *CustController) GetAllCustomers(w http.ResponseWriter, r *http.Request) {
	// Get all
	if cust, err := cc.Repository.GetAll(); err != nil {
		if errors.Is(err, domain.DataNotFound) {
			http.Error(w, err.Error(), http.StatusBadRequest)
			return
		}
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return

	} else {
		j, err := json.Marshal(cust)
		if err != nil {
			http.Error(w, err.Error(), http.StatusInternalServerError)
		}
		w.Header().Set("Content-Type", "application/json")
		w.WriteHeader(http.StatusOK)
		w.Write(j)
	}
}

func (h *CustController) GetCustomerById(w http.ResponseWriter, r *http.Request) {
	// Getting route parameter id
	id := r.PathValue("id")
	// Get by id
	if note, err := h.Repository.GetById(id); err != nil {
		if errors.Is(err, domain.DataNotFound) {
			http.Error(w, err.Error(), http.StatusBadRequest)
			return
		}
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	} else {
		w.Header().Set("Content-Type", "application/json")
		j, err := json.Marshal(note)
		if err != nil {
			http.Error(w, err.Error(), http.StatusInternalServerError)
		}
		w.WriteHeader(http.StatusOK)
		w.Write(j)
	}
}

func (cc *CustController) CreateNewCustomer(w http.ResponseWriter, r *http.Request) {
	var cust domain.Customer
	//get incomming request
	err := json.NewDecoder(r.Body).Decode(&cust)
	if err != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}
	//Success
	if err := cc.Repository.Create(cust); err != nil {
		if errors.Is(err, domain.DataExist) {
			http.Error(w, err.Error(), http.StatusBadRequest)
			return
		}
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}
	message := fmt.Sprintf("Customer created successfully: %s", cust.ID)
	j, err := json.Marshal(message)
	if err != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
	}
	w.WriteHeader(http.StatusCreated)
	w.Write(j)
}

func (cust *CustController) UpdateCustomer(w http.ResponseWriter, r *http.Request) {
	// Getting route parameter id
	id := r.PathValue("id")
	var note domain.Customer
	// Decode the incoming note json
	err := json.NewDecoder(r.Body).Decode(&note)
	if err != nil {
		http.Error(w, err.Error(), http.StatusNotFound)
		return
	}
	// Update
	if err := cust.Repository.Update(id, note); err != nil {
		http.Error(w, err.Error(), http.StatusNotFound)
		return
	}
	w.WriteHeader(http.StatusNoContent)
}

func (h *CustController) DeleteCustomer(w http.ResponseWriter, r *http.Request) {
	// Getting route parameter id
	id := r.PathValue("id")
	// delete
	if err := h.Repository.Delete(id); err != nil {
		http.Error(w, err.Error(), http.StatusNotFound)
		return
	}
	message := fmt.Sprintf("Customer deleted: %s", id)
	j, err := json.Marshal(message)
	if err != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
	}
	w.WriteHeader(http.StatusNoContent)
	w.Write(j)
}

// Add function to add new customer.
func (cc CustController) Add(c domain.Customer) {
	fmt.Println("Add operation")
	err := cc.Repository.Create(c)
	if err != nil {
		fmt.Println("Error: ", err)
		return
	}
	fmt.Println("new Customer has been created")
	fmt.Println("-----------------------")
}

func (cc CustController) Update(id string, c domain.Customer) {
	fmt.Println("Update operation")
	err := cc.Repository.Update(id, c)
	if err != nil {
		fmt.Println("Error: ", err)
		return
	}
	fmt.Println("new Customer has been updated")
	fmt.Println("-----------------------")
}

func (cc CustController) Delete(id string) {
	fmt.Println("Delete operation")
	err := cc.Repository.Delete(id)
	if err != nil {
		fmt.Println("Error: ", err)
		return
	}
	fmt.Println("new customer has been deleted")
	fmt.Println("-----------------------")
}
func (cc CustController) FetchById(id string) {
	fmt.Println("FetchById operation")
	data, err := cc.Repository.GetById(id)
	if err != nil {
		fmt.Println("Error: ", err)
		return
	}

	fmt.Println("ID:", data.ID)
	fmt.Println("Name:", data.Name)
	fmt.Println("ID:", data.Email)
	fmt.Println("-----------------------")
}
func (cc CustController) FetchAll() {
	fmt.Println("FetchAll operation")
	data, err := cc.Repository.GetAll()
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
