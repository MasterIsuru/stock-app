import { render, screen } from "@testing-library/react";
import NotFound from "./index";

test("renders page loading", () => {
  render(<NotFound />);
  const linkElement = screen.getByText(/Loading/i);
  expect(linkElement).toBeInTheDocument();
});
