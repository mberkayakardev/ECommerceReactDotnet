import { useEffect, useState } from 'react'
import '../App/App.css'
import { Outlet } from 'react-router'
import Typography from '@mui/material/Typography';
import Header from '../../Header/Header';
import CssBaseline from '@mui/material/CssBaseline';



function App() {
  
  
  return(
    <>
    <CssBaseline/>
    <Outlet/>
    </>
  )

}

export default App



 
  






