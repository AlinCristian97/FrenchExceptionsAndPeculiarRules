# Instructions: Add a French Exception or Peculiar Rule

You are an AI assistant helping maintain a C# repository that catalogues French grammar exceptions, idioms, and peculiar rules. When the user pastes in a reference to a rule — a paragraph, a sentence they noticed in a text, something from a course, a grammar note, or any French language observation — your job is to **create a new `ExceptionRule` entry** and append it to the list in the repository file.

---

## Repository Details

- **Solution:** `FrenchExceptionsAndPeculiarRules`
- **Target file:** `ExceptionsAndPeculiarRulesRepository.cs`
- **Class used:** `ExceptionRule` (defined in `ExceptionRule.cs`)

### `ExceptionRule` Constructor Signature

```csharp
public ExceptionRule(
    string textWhereNoticed,
    string mainActor,
    string explanation,
    string? notes = null
)
```

### Field Descriptions

| Parameter | Purpose | Guidelines |
|---|---|---|
| `textWhereNoticed` | The exact French text (or a representative example) where the rule was observed. | Use actual French phrases separated by ` / ` if multiple examples. Keep it short — a few example sentences, not a full paragraph. |
| `mainActor` | The key grammatical element, word, or concept at the heart of the rule. | A concise label — could be a word (`de`), a pair (`que / quoi`), or a short descriptor (`BAGS adjectives`, `color adjectives agreement`). |
| `explanation` | A clear explanation of the rule **written entirely in French**. | Explain *why* the rule exists, *when* it applies, and *how* it differs from the default/expected behavior. Use `«` and `»` for inline French quotes. Use `**bold**` markdown for emphasis inside the string. Use `\n` for line breaks when listing sub-rules. |
| `notes` | Optional. Additional examples, conjugation tables, common mistakes, and a "Règle rapide" summary — **all in French**. | Use `\n` for line breaks, `• ` for bullet points. Always end with a `Règle rapide :` one-liner summarizing the rule. Mark incorrect examples with `Incorrect :`. |

---

## Step-by-Step Process

### 1. Analyze the User's Input

The user may provide:
- A French sentence or paragraph they encountered
- A grammar rule description (in French or English)
- A textbook excerpt, course note, or correction they received
- A question about why something works a certain way in French

Extract the **core grammatical rule, exception, or peculiarity** from their input.

### 2. Check for Duplicates

Scan the existing entries in `ExceptionsAndPeculiarRulesRepository.cs`. If an entry with the same `mainActor` or covering the same grammatical concept already exists, **tell the user** and ask whether they want to:
- Update/enrich the existing entry
- Add it as a separate entry anyway (if it covers a different angle)

### 3. Compose the New Entry

Write a new `ExceptionRule(...)` block following these conventions:

- **Language:** All `explanation` and `notes` content must be in **French**.
- **String style:** Use `"string" +` concatenation with proper alignment (see existing entries for formatting). Indent continuation lines with spaces to align with the opening `"` of the first line of that parameter.
- **Newlines:** Use `\n` inside strings, not actual C# newlines.
- **Bullet points:** Use `"• "` (bullet + space).
- **Numbered lists:** Use `"1. "`, `"2. "`, etc.
- **Inline French quotes:** Use `« »` with spaces inside: `« word »`.
- **Bold emphasis:** Use `**text**` inside strings where helpful.
- **Examples section:** Include 2–5 clear French examples showing correct usage.
- **Incorrect examples:** Always include at least one `Incorrect :` example when relevant.
- **Règle rapide:** Always end the `notes` with a concise one-line summary starting with `Règle rapide :`.
- **Trailing comma:** Place a trailing comma after the closing `)` of each entry, followed by a blank line before the next entry.

### 4. Insert the Entry

Append the new `ExceptionRule(...)` block as the **last entry** in the `ExceptionsAndPeculiarRules` list, just before the closing `};`. Maintain the existing formatting — 8-space indentation for `new ExceptionRule(`, 12-space indentation for named parameters.

### 5. Verify

After inserting, verify the file still compiles (no syntax errors, matching parentheses/braces, correct string escaping).

---

## Formatting Template

```csharp
        new ExceptionRule(
            textWhereNoticed: "Example French sentence 1 / Example French sentence 2",
            mainActor: "key grammatical element",
            explanation: "Clear explanation in French of the rule, when it applies, " +
                         "and how it differs from the default behavior.",
            notes: "Exemples :\n" +
                   "• Example 1 → explanation\n" +
                   "• Example 2 → explanation\n" +
                   "Incorrect : common mistake example\n" +
                   "Règle rapide : one-line summary of the rule."
        ),
```

---

## Examples of Valid User Inputs and Expected Behavior

**User pastes:** *"In my course they said you use 'du', 'de la', 'des' for partitive but after negation it becomes just 'de'"*
→ Check if a `de` negation rule already exists. If yes, inform user. If no, create a new entry about partitive articles becoming `de` in negative sentences.

**User pastes:** *"Elle s'est lavé les mains — why no agreement on lavé?"*
→ Create an entry about reflexive verbs in passé composé where the direct object follows the verb (no past participle agreement).

**User pastes:** *"J'habite en France / J'habite au Japon"*
→ Create an entry about the preposition rules for countries (en + feminine/vowel, au + masculine consonant, aux + plural).

---

## Important Reminders

- Never remove or reorder existing entries.
- Preserve the exact whitespace and formatting style of the file.
- If the user's input is ambiguous, ask a clarifying question before creating the entry.
- If the rule is well-known and straightforward (not really an "exception" or "peculiarity"), still add it — the repository also tracks rules that are tricky for learners, not just formal exceptions.
