import { Link, Route, Routes } from "react-router-dom";
import App from "./App";
import AddStudent from "./addstudent";
import DeleteStudent from "./delete";
import Whethercast from "./whethercast";
import "./nav.css";

function Nav() {
  return (
    <div>
      <nav className="navbar">
        <h1>Home</h1>
        <div className="nav-links">
          <Link to="/">Home</Link>
          <Link to="/add-student">Add Student</Link>
          <Link to="/delete-student">Delete Student</Link>
          <Link to="/wherever">Wherever</Link>
        </div>
      </nav>
      <Routes>
        <Route path="/" element={<App />} />
        <Route path="/add-student" element={<AddStudent />} />
        <Route path="/delete-student" element={<DeleteStudent />} />
        <Route path="/wherever" element={<Whethercast />} />
      </Routes>
    </div>
  );
}

export default Nav;
