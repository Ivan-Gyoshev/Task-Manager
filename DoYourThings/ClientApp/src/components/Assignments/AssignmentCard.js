import * as React from "react";
import AssignmentRow from "./AssignmentRow";
const AssignmentCard = ({ assignments }) => {
  return (
    <article>
      {assignments.length > 0 ? (
        <>
          {assignments.map((x) => (
            <AssignmentRow assignment={x} />
          ))}
        </>
      ) : (
        <h2>You don't have any assignments yet.</h2>
      )}
    </article>
  );
};

export default AssignmentCard;
