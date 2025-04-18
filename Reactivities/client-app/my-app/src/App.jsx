import './App.css'
 import { useState } from 'react'
 
export default function App() {

  const data=[
    {name:"a", mobileNo:1},
    {name:"b", mobileNo:2},
    {name:"c", mobileNo:3}
  ];

  const [count,setCountt]=useState(0);

  const PropHandler =()=>{
    setCountt(count+1);
  }


  return (
      <>
      <div >

        <h1>Welcome to my app</h1>
 
        <MyButton />
          <MyButton2 />
          <MyButton2 />
          <p>Propes example</p>
          <PropsExample count={count} onClick={PropHandler}/>
          <PropsExample count={count} onClick={PropHandler}/>
          <ListPropsExample datasss={data}/>
        </div>
      </>
  )
}
//List passing from parent commpont to child
const ListPropsExample=({datasss})=>{

  const data=datasss.map((customer,index)=>
<li key={index}>  <strong>{customer.name}</strong> - {customer.mobileNo}</li>
  );

  return(
    <>
    <ul>{data}</ul>
    </>
  )
}
//Propes passing data from parent component to child 
const PropsExample=({count, onClick})=>{

  return(
     
    <button className='avatar' onClick={onClick}>Button3 clicked {count} times</button>
    
  );
}

const MyButton2=()=>{   

  const[couter,setCount]=useState(0);
  const myhandler=()=>{
      setCount(couter+1);
  }
  const resetCounter=()=>{
    setCount(0)
     
  }


  return (
<>
<p>Counter:{couter}</p>
<button className='avatar' onClick={myhandler}> Clicked {couter} times</button>
<button className='avatar' onClick={resetCounter}> Reset counter</button>
</>

  );
}


const MyButton=()=> {

  const products = [
    { title: "Cabbage", id: 1 },
    { title: "Garlic", id: 2 },
    { title: "Apple", id: 3 }
  ];
  const listItems = products.map(product =>{
    <li key={product.id}>
      {product.title}
    </li>
});
    return (
      <>
     
       <ul>{listItems}</ul>
      <button  className="avatar">I am button</button>
      </>
  )
}
 
