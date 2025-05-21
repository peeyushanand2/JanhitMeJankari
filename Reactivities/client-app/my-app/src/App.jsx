import React from "react"; 
import { PropsTest,ConditionalRendering,ConditionalRender,
  ConditionalRenderUsingAND,SwitchCaseTest,UseStateTest,ListMap} 
from "./InterviewPractice/ReactBasicDemo";
import {Load} from "./InterviewPractice/LoadingSate";

const Welcome=(props)=>{
return <h1>Hi {props.children}</h1>
};
const App = () => {
    return (
      // <Welcome><>
      <>
        <div>
     
          <h1 >This is my App Page</h1>
         
          <PropsTest Name=" This is passed from Parent component"></PropsTest>
          <UseStateTest />
          <ConditionalRendering isPacked={true} name="Peeyush" />
          <ConditionalRender isLoggedIn={false}></ConditionalRender>
          <ConditionalRenderUsingAND hasNotifications={true} />
          <SwitchCaseTest status="loading"></SwitchCaseTest>
         <ListMap></ListMap>
         <Load></Load>
        </div>
        </>
      //  </Welcome>
    );
};

export default App;