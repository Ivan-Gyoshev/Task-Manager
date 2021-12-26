import * as React from "react";
import { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import * as assignmentService from "../../services/assignmentsService";

const AssignmentRow = ({ assignment }) => {
  const [asign, setAssignment] = useState({});
  const [hidden, setHidden] = useState(false);
  const userId = JSON.parse(localStorage.getItem("user"))?.id;

  useEffect(() => {
    assignmentService
      .getCurrent(assignment.id)
      .then((assignment) => setAssignment(assignment));
  }, []);

  const handleDelete = (e) => {
    assignmentService.deleted(asign.id)
    .then(() => setAssignment(""))
    .then(() => setHidden(true));
  };

  return (
    <article className="assign-row">
      <p>{asign.title}</p>
      <span>{asign.date}</span>
      {
        !hidden &&
        <Link to="/today" onClick={() => handleDelete(asign.id)}>
          <i className="fas fa-times"></i>
        </Link>
      }
      {
         !hidden &&
        <Link to="/today">
          <i className="fas fa-check"> </i>
        </Link>
      }
    </article>
  );
};

export default AssignmentRow;
