import { Email, Password } from '@mui/icons-material';
import {Typography, TextField} from '@mui/material';
import { useEffect, useRef, useState } from 'react';
import { UNSAFE_createBrowserHistory, useFetcher } from 'react-router';

export default function LoginPage()
{

const UserEmail = useRef(null);
const UserPassword= useRef(null);
var  degiskenson = useRef(2);

let [degersayi, setDegerSayi] = useState(0)


function HandleSubmit(e)
{
  // console.log(UserEmail.current);

  // console.log(UserEmail.current.value);
  // console.log(UserPassword.current.value)
  // e.preventDefault();

  // console.log("user email berkayakar.com.tr olacak")

  // UserEmail.current.value = "BerkayAkar@gmail.com"

  // console.log(UserEmail.current.value);
}

function degerarttir(){
  // degersayi = degersayi + 1

  // setDegerSayi(degersayi)
  // console.log(degersayi)
  degiskenson.current +=  1 
  console.log(degiskenson)
}


return(
  <>

   <form onSubmit={HandleSubmit}>
    <div className="header">
      <h1>Login</h1>
      {degersayi}
      <p>Please enter your login and password!</p>
      {degiskenson.current}
      </div>
      <div className="mb-3">
        <label htmlFor="email" className="form-label"> Email  </label>
        <input type="email" className="form-control" id="email" name='email' ref={UserEmail} />
      </div>
      
      <div className="mb-4">
        <label htmlFor="password" className="form-label"> Password  </label>
        <input type="password" className="form-control" id="password" name='password' ref={UserPassword}/>
      </div>

      <div className="mb-3">
        <button className="btn btn-outline-warning me-2">Submit</button>
        <button type='button' className="btn btn-outline-warning me-2" onClick={degerarttir}>deger arttır </button>
        <button className="btn btn-outline-light">Reset</button>
      </div>
    
    </form>
   
  {/* <form onSubmit={HandleSubmit}>
    <div className="header">
      <h1>Login</h1>
      <p>Please enter your login and password!</p>
      </div>
      <div className="mb-3">
        <label htmlFor="email" className="form-label"> Email  </label>
        <input type="email" className="form-control" id="email" name='email' value={newLoginnfo.Email} onChange={HandleChangeInput} />
      </div>
      
      <div className="mb-4">
        <label htmlFor="password" className="form-label"> Password  </label>
        <input type="password" className="form-control" id="password" name='password' value={newLoginnfo.Password} onChange={ HandleChangeInput }/>
      </div>

      <div className="mb-3">
        <button className="btn btn-outline-warning me-2">Submit</button>
        <button className="btn btn-outline-light">Reset</button>
      </div>
    
    </form> */}


        {/* <form onSubmit={HandleSubmit}>
      <div className="header">
        <h1>Login</h1>
        <p>Please enter your login and password!</p>
      </div>
      <div className="mb-3">
        <label htmlFor="email" className="form-label">
          Email
        </label>
        <input type="email" className="form-control" id="email" name='email' value={newEmail} onChange={e => setEmail(e.target.value)} />
      </div>
      <div className="mb-4">
        <label htmlFor="password" className="form-label">
          Password
        </label>
        <input type="password" className="form-control" id="password" name='password' value={newPassword} onChange={ e => setPassword(e.target.value )}/>
      </div>
      <div className="mb-3">
        <button className="btn btn-outline-warning me-2">Submit</button>
        <button className="btn btn-outline-light">Reset</button>
      </div>
    </form> */}


    
        </>
    )
}
