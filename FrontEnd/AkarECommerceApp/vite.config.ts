import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

// https://vite.dev/config/
/// Uygulamanın ayağa kalkacağı portu burada belirleyebiliyoruz. 
export default defineConfig({
  server:{
    port : 3000
  },
  plugins: [react()],
})
