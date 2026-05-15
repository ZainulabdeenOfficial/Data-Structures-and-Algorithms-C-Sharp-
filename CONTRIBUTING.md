# Contributing

Thanks for taking the time to contribute to **Data Structures and Algorithms (C#)**.

## Ways to contribute

- Add a new data structure / algorithm implementation
- Add new practice problems and solutions
- Improve explanations and Big‑O analysis
- Fix bugs, edge cases, or improve readability
- Improve documentation (`README.md`, `Theory.md`, `learn.md`)

## Before you start

- Keep changes focused and easy to review.
- Prefer clear, readable code over clever code.
- Add a short explanation and complexity analysis for each solution.

## Repository structure (recommended)

- Each topic lives in its own folder (example: `Array/`).
- Prefer one algorithm/problem per file.
- Use descriptive names.

If you add a new topic folder, follow the same naming pattern as existing folders.

## Code guidelines (C#)

- Use meaningful names for variables and methods.
- Keep methods small and focused.
- Add comments only where they add clarity (avoid restating obvious code).
- Handle edge cases (empty input, null where applicable, single element, etc.).

## Documentation requirements for solutions

When adding a new solution, include:

1. **Problem / Goal** (1–3 lines)
2. **Approach** (brief explanation)
3. **Time complexity** (Big‑O)
4. **Space complexity** (Big‑O)
5. **Example** (optional but encouraged)

You can include this in:
- A short comment header in the `.cs` file, and/or
- A `README.md` inside the topic folder

## Testing / examples

At minimum, provide at least **2–3 example inputs/outputs** in comments or documentation.

If the repo later adopts a test framework (xUnit/NUnit/MSTest), contributions may include unit tests.

## Commit & PR guidelines

- Use clear commit messages (e.g., `Add binary search`, `Fix edge case in merge sort`).
- PR title should summarize the change.
- In the PR description, mention:
  - what you added/changed
  - which folder/topic
  - complexity (if you added solutions)

## License

By contributing, you agree that your contributions will be licensed under the same license as this repository.
