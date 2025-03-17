import React from "react";
import Grid from "./Grid";
import spreadOperator from "./spreadOperator";

const CRUD = () => {
  const users = [
    { id: 1, firstName: "Mark", lastName: "Otto", username: "@mdo" },
    { id: 2, firstName: "Jacob", lastName: "Thornton", username: "@fat" },
    { id: 3, firstName: "Larry", lastName: "the Bird", username: "@twitter" },
  ];
const emp={name:"peeyush",age:10};
  return (
  <>

  <Grid user={users} ></Grid>


  </>
  );
};

export default CRUD;
