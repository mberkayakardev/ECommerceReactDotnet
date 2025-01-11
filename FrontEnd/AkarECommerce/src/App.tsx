// import { useState } from 'react'
import './App.css'
import Category from './assets/KategoryComponent/Category.tsx'
import Navbar from './assets/NavbarComponent/Navbar.tsx'
import BaseProductComponent from './assets/ProductComponents/BaseProductComponent.tsx'

function App() {
 
  return (
    <>
    <Navbar/>
    <Category/>
    <BaseProductComponent/>

    </>
  )
}

export default App
