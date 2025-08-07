import React, { useState } from 'react';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';

function App() {
  const [activeView, setActiveView] = useState('book');

  const renderComponent = () => {
    // 1. if-else
    if (activeView === 'book') return <BookDetails />;
    else if (activeView === 'blog') return <BlogDetails />;
    else if (activeView === 'course') return <CourseDetails />;
    else return <p>Select a valid section</p>;
  };

  return (
    <div style={{ padding: '30px' }}>
      <h1 style={{ textAlign: 'center' }}>📚 Blogger App Dashboard</h1>

      {/* Buttons for switching views */}
      <div style={{ textAlign: 'center', marginBottom: '20px' }}>
        <button onClick={() => setActiveView('book')}>Book Details</button>{' '}
        <button onClick={() => setActiveView('blog')}>Blog Details</button>{' '}
        <button onClick={() => setActiveView('course')}>Course Details</button>
      </div>

      {/* 2. Function-based conditional rendering */}
      {renderComponent()}

      {/* 3. Ternary rendering example below heading */}
      <p style={{ textAlign: 'center' }}>
        Viewing: {activeView === 'book' ? 'Books' : activeView === 'blog' ? 'Blogs' : 'Courses'}
      </p>
    </div>
  );
}

export default App;
