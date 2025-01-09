package memstore

import (
	"fmt"

	"customerapp/domain"
)

type CustomerRepository struct {
	repository map[string]domain.Customer
}

// NewCustomerRepository initialises the memory data repository
func NewCustomerRepository() *CustomerRepository {
	return &CustomerRepository{repository: make(map[string]domain.Customer)}
}

func (cr CustomerRepository) Create(cust domain.Customer) error {
	if len(cust.ID) == 0 {
		return domain.ValidID
	}
	if len(cust.Name) == 0 {
		return domain.ValidName
	}
	if len(cust.Email) == 0 {
		return domain.ValidEmail
	}
	cr.repository[cust.ID] = cust
	return nil
}
func (cr CustomerRepository) Update(id string, cust domain.Customer) error {
	if _, ok := cr.repository[id]; !ok {
		return domain.DataNotExist
	}
	cr.repository[id] = cust
	return nil
}

func (cr CustomerRepository) Delete(id string) error {
	if _, ok := cr.repository[id]; !ok {
		return fmt.Errorf("failed in Delete:%w", domain.DataNotExist)
	}
	delete(cr.repository, id)
	return nil
}

func (cr CustomerRepository) GetById(id string) (domain.Customer, error) {
	if _, ok := cr.repository[id]; !ok {
		return domain.Customer{}, fmt.Errorf("failed in GetbyId:%w", domain.DataNotExist)
	}
	dat := cr.repository[id]
	return dat, nil
}

func (cr CustomerRepository) GetAll() ([]domain.Customer, error) {
	if len(cr.repository) == 0 {
		return nil, domain.DataNotFound
	}
	//var lst []domain.Customer
	lst := make([]domain.Customer, 0, len(cr.repository))
	for c := range cr.repository {
		lst = append(lst, cr.repository[c])
	}
	return lst, nil
}
