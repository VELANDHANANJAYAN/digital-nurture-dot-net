import React from 'react';
import FlightDetails from './FlightDetails';

const GuestPage = () => {
  return (
    <div>
      <h2>👋 Welcome Guest</h2>
      <p>Please log in to book your flight tickets.</p>
      <FlightDetails />
    </div>
  );
};

export default GuestPage;
