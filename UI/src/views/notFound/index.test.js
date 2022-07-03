import { render, screen } from "@testing-library/react";
import NotFound from "./index";

test("renders page not found", () => {
  render(<NotFound />);
  const linkElement = screen.getByText(/Page Not Found/i);
  expect(linkElement).toBeInTheDocument();
});
