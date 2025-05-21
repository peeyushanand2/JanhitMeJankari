import React,{useState} from 'react'
import '../ButtonStyle.css'

export const PropsTest=(props)=>{
  return  <p>Hello Props:{props.Name}</p>
};
export const UseStateTest=()=>{
     const[count, setCount]=useState(0);
     const clickme=()=>{
        setCount(count+1); 
     }
    return (
        <>
            <p>{count}</p>
            <button className='button-default' onClick={clickme} >Click me </button>
            </>
    )
};
//1. Using If/Else Statements
export const ConditionalRendering=({name, isPacked})=>{
if(isPacked){
    return <li className="item">{name} ✅</li>;
};
return <li className="item">{name}</li>;
};
//2. Using Ternary Operator
export const ConditionalRender=({isLoggedIn})=>{
    return(
    <p>{isLoggedIn?"Welcome Back":"Please login"}</p>
   );
};
//3. Using Logical AND (&&) Operator
export const ConditionalRenderUsingAND=({hasNotifications })=>{
    return(
<div> {hasNotifications && <p>You have new notificaton!!</p>}</div>
    );
};
//4. Using Switch Case Statements

export const SwitchCaseTest=({status})=>{
switch(status){
    case 'loading':
         return <p>Loading </p>;
    case 'success':
        return <p>Successssss</p>
    default:
        return <p>Unkown</p>;
   }
};
//5. Conditional Rendering in Lists (Using .map())
 export const ListMap=()=>{
    const item =["apple","Banana","Cerry"];
    return item.map((item,index)=><li key={index}> {item}</li>);

 }