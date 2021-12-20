import * as React from "react";
import { useState, useEffect } from "react";
import * as assignmentService from "../../services/assignmentsService";
import AssignmentCard from "../Assignments/AssignmentCard";

export const Dashboard = () => {
  const [assignments, setAssignments] = useState([]);

  useEffect((e) => {
    assignmentService.getAll()
      .then((result) => {
        setAssignments(result);
      })
      .catch((err) => {
        console.log(err);
      });
  }, []);

  return (
    <article className="daily">
      <article className="assignment-info">
        <h2>Assignments: </h2>
        <AssignmentCard assignments={assignments} />
      </article>
    </article>
  );
};
