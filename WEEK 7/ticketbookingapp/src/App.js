import React, { useState } from 'react';
import GuestPage from './components/GuestPage';
import UserPage from './components/UserPage';

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  // Toggle login/logout
  const handleLoginLogout = () => {
    setIsLoggedIn(!isLoggedIn);
  };

  // Element variable for rendering
  let page;
  if (isLoggedIn) {
    page = <UserPage />;
  } else {
    page = <GuestPage />;
  }

  return (
    <div style={{ padding: '30px' }}>
      <h1 style={{ textAlign: 'center' }}>🎟️ Ticket Booking App</h1>

      <div style={{ textAlign: 'center', marginBottom: '20px' }}>
        <button onClick={handleLoginLogout}>
          {isLoggedIn ? 'Logout' : 'Login'}
        </button>
      </div>

      {/* Conditional Rendering using Element Variable */}
      {page}
    </div>
  );
}

export default App;
