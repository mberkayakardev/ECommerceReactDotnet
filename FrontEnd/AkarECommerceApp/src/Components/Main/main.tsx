import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import '../../index.css'
import App from '../App/App.tsx'

createRoot(document.getElementById('root')!).render(
///  strict mode esasında development yaparken hatalarınızı söyleyen bir moddur.  
  <StrictMode> 
    <App />
  </StrictMode>,
)
