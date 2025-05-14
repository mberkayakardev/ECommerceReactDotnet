import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import '../../index.css'
import App from '../App/App.tsx'
import { router } from '../../Router/Routes.tsx'
import { RouterProvider } from 'react-router'
import { Provider } from 'react-redux'
import { AppStore } from '../../Store/AppStore.ts'

createRoot(document.getElementById('root')!).render(
  <StrictMode> 
    <Provider store={AppStore }>
      <RouterProvider router={router}/> 
    </Provider>
  </StrictMode>,
)
