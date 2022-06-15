import React from 'react';
import './App.css';
import './Navbar.css';
import { BrowserRouter as Router,Routes, Route, Link } from 'react-router-dom';
import Register from './pages/Register'
import Home from './pages/Home'
import Vacations from './pages/Vacations';
import Profile from './pages/Profile';
import axios from 'axios';

function App() {
  return(
    <div className='App'>
      <Router>
    <nav className="NavbarItems">
                <h1 className='navbar-logo'>FlySafe<i className='fab fa-react'></i></h1>
                <Link className='nav-links' to="/">Home</Link>
                <Link className='nav-links' to="/Vacations">Vacations</Link>
                <Link className='nav-links' to="/Profile">Profile</Link>
                <Link className='nav-links' to="/Register">Register</Link>
     </nav>
                <Routes>
                <Route exact path="/" element={ < Home />}></Route>
                <Route exact path='/Vacations' element={< Vacations />}></Route>
                <Route exact path='/Profile' element={< Profile />}></Route>
                <Route exact path='/Register' element={< Register />}></Route>
                </Routes>
            </Router>
    </div>
  )
}

export default App;