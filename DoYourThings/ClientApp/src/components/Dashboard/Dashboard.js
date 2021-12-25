import * as React from "react";
import { Link } from "react-router-dom";
import { useState, useEffect } from "react";
import * as assignmentService from "../../services/assignmentsService";
import AssignmentCard from "../Assignments/AssignmentCard";

export const Dashboard = () => {
  const [assignments, setAssignments] = useState([]);

  useEffect(() => {
    assignmentService
      .getAll()
      .then((result) => {
        setAssignments(result);
      })
      .catch((err) => {
        console.log(err);
      });
  }, []);

  return (
    <>
      <article className="daily">
        <Link
          to="/assignment-create"
          className="add-assign"
        >
          Add Assignment
        </Link>
        {/* <a href="/assignment-create" className="add-assign">Add Assignment</a> */}
        <article className="assignment-info">
          <h2>Assignments: </h2>
          <AssignmentCard assignments={assignments} />
        </article>
      </article>
    </>
  );
};
