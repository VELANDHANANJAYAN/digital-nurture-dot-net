import React from 'react';
import FlightDetails from './FlightDetails';

const UserPage = () => {
  return (
    <div>
      <h2>👤 Welcome Back, User</h2>
      <p>You can now book tickets below.</p>
      <FlightDetails />

      <div style={{ marginTop: '20px' }}>
        <button>Book Flight: Indigo 6E123</button><br /><br />
        <button>Book Flight: Air India AI455</button>
      </div>
    </div>
  );
};

export default UserPage;
