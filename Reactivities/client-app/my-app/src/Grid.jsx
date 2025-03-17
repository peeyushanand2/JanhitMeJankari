import React, { useState,useEffect } from "react"; 
import "bootstrap/dist/css/bootstrap.min.css";

const Grid=({user})=>{

    const [mydata, mySetData]=useState([]);
    useEffect(()=>{
        mySetData(user);
    });

const handEdit=(id)=>{

    alert(id);
}
const handleDelete=(id)=>{
    if(window.confirm("are you sure  to delete"));
    alert(id);

}
    return(
    <>
      <div className="container mt-4">
      <h2 className="mb-3">User List</h2>
      <table className="table table-bordered table-striped">
        <thead className="table-dark">
          <tr>
            <th>S.N.</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>User Name</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {
          
          mydata.map((user) => (
            <tr key={user.id}>
              <td>{user.id}</td>
              <td>{user.firstName}</td>
              <td>{user.lastName}</td>  
              <td>{user.username}</td>
                <td colSpan={2}  >
                    <button className="btn btn-primary" onClick={()=>handEdit(user.id)} >Edit</button> &nbsp;
                    <button  className="btn btn-danger" onClick={()=>handleDelete(user.id)}>Delete</button>
                </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
    </>
    );
};

export default Grid;