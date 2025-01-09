package memstore

import (
	"testing"

	"github.com/stretchr/testify/assert"

	"customerapp/domain"
)

func TestCustomerRespository_CreateValidCustomer(t *testing.T) {
	var wantError error
	cust := domain.Customer{
		ID:    "1",
		Name:  "test1",
		Email: "Test1@gmail.com",
	}
	wantError = nil
	repository := NewCustomerRepository()
	err := repository.Create(cust)
	assert.Equal(t, wantError, err, "failed to create customer")
}
