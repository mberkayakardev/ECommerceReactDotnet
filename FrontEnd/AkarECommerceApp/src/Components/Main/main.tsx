import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import '../../index.css'
import App from '../App/App.tsx'
import { router } from '../../Router/Routes.tsx'
import { RouterProvider } from 'react-router'

createRoot(document.getElementById('root')!).render(
///  strict mode esasında development yaparken hatalarınızı söyleyen bir moddur.  
  <StrictMode> 
    {/* <App /> */}
    <RouterProvider router={router}/>
  </StrictMode>,
)
