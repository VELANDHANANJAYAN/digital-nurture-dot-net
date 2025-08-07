import React from 'react';

const IndianPlayers = () => {
  const players = ['Virat', 'Rohit', 'Gill', 'Dhoni', 'Pant', 'Hardik'];

  // Destructuring
  const [p1, p2, p3, p4, p5, p6] = players;
  const oddTeam = [p1, p3, p5];
  const evenTeam = [p2, p4, p6];

  // Merging arrays using ES6 spread operator
  const t20Players = ['Surya', 'Ishan'];
  const ranjiPlayers = ['Rahane', 'Pujara'];
  const allPlayers = [...t20Players, ...ranjiPlayers];

  return (
    <div>
      <h2>Odd Team Players (ES6 Destructuring):</h2>
      {oddTeam.map((player, index) => <p key={index}>{player}</p>)}

      <h2>Even Team Players (ES6 Destructuring):</h2>
      {evenTeam.map((player, index) => <p key={index}>{player}</p>)}

      <h2>Merged Players (T20 + Ranji - using Spread Operator):</h2>
      {allPlayers.map((player, index) => <p key={index}>{player}</p>)}
    </div>
  );
};

export default IndianPlayers;
