========================================
Source Code (between the arrows)
========================================

🡆macronutrients <eQxYylc3> ->

    water <tdgS8qBO>,
	fiber <OpdFntBx> ->

        what <MLUxjdg8>,
        not <qkVgxZIs>;;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'macronutrients ')
│   │   └── tag
│   │       ├── T(LEFT_ARROW|'<')
│   │       ├── T(DATA|'eQxYylc3')
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'water ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'tdgS8qBO')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── expression
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'fiber ')
│   │       │   └── tag
│   │       │       ├── T(LEFT_ARROW|'<')
│   │       │       ├── T(DATA|'OpdFntBx')
│   │       │       └── T(RIGHT_ARROW|'> ')
│   │       ├── producer
│   │       │   ├── T(HYPHEN|'-')
│   │       │   └── T(RIGHT_ARROW|'>\r\n\r\n        ')
│   │       ├── item_or_expression_list
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'what ')
│   │       │   │   │   └── tag
│   │       │   │   │       ├── T(LEFT_ARROW|'<')
│   │       │   │   │       ├── T(DATA|'MLUxjdg8')
│   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │       │   └── item
│   │       │       ├── text_chunk
│   │       │       │   └── T(DATA|'not ')
│   │       │       └── tag
│   │       │           ├── T(LEFT_ARROW|'<')
│   │       │           ├── T(DATA|'qkVgxZIs')
│   │       │           └── T(RIGHT_ARROW|'>')
│   │       └── T(TERMINATOR|';')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')