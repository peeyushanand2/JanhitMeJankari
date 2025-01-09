package domain

import "errors"

type Customer struct {
	ID    string `json:"id,omitempty"`
	Name  string `json:"name"`
	Email string `json:"email,omitempty"`
}

type CustomerRepository interface {
	Create(Customer) error
	Update(string, Customer) error
	Delete(string) error
	GetById(string) (Customer, error)
	GetAll() ([]Customer, error)
}

var (
	ValidID      = errors.New("id can not be empty")
	ValidName    = errors.New("name can not be emplty")
	ValidEmail   = errors.New("email can not be emplty")
	DataNotExist = errors.New("customer doesn't exsit")
	DataExist    = errors.New("customer already exsit")
	DataNotFound = errors.New("there is no record in the list")
)
