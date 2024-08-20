import { useState } from 'react'
import './App.css'

function App() {
  
    const [count, setCount] = useState(0);
    
    return (
      <>
        <div>
          <button onClick={() => setCount(count + 1)}>Add</button>
          <button onClick={() => setCount(count - 1)}>Subtract</button>
          <p>{count}</p>
        </div>
      </>
    );
  
}

export default App
