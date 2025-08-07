import React from 'react';

const ListOfPlayers = () => {
  const players = [
    { name: 'Virat', score: 85 },
    { name: 'Rohit', score: 95 },
    { name: 'Gill', score: 45 },
    { name: 'Dhoni', score: 90 },
    { name: 'Pant', score: 30 },
    { name: 'Surya', score: 76 },
    { name: 'Hardik', score: 88 },
    { name: 'Jadeja', score: 67 },
    { name: 'Bumrah', score: 55 },
    { name: 'Shami', score: 40 },
    { name: 'Ashwin', score: 77 },
  ];

  const filteredPlayers = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>All Players (ES6 map):</h2>
      {players.map((p, index) => (
        <p key={index}>{p.name} - {p.score}</p>
      ))}

      <h2>Filtered Players (score &lt; 70 using arrow function):</h2>
      {filteredPlayers.map((p, index) => (
        <p key={index}>{p.name} - {p.score}</p>
      ))}
    </div>
  );
};

export default ListOfPlayers;
