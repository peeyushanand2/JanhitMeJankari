import React  from "react";
import { useState } from "react";

const Test=()=>{
const arr=["item1","Item2","Item3"]
const[item,setItem]=useState(arr)

const deleteItem=(id)=>{
   const copyarr=[...arr];
   copyarr.splice(id,1);
   setItem(copyarr);
}

return (
<>
<div>
    <ul>
     arr.map((index,item)={
        <li key={index}> {item}
         <button onClick={()=>deleteItem(index)} >Delete</button>   
        </li>
     })
    </ul>
</div>
</>

)

}
export default Test;