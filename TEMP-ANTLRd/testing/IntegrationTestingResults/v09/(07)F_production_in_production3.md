========================================
Source Code (between the arrows)
========================================

🡆macronutrients <oVs6tsnU> ->

    water <9Y9uFDwu>,
	fiber <PALnQoTQ> ->

        what <6hlYVfaz>,
        not <gubSBEDe>;

	somth else <hAyLdw3m>;🡄

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
│   │       ├── T(DATA|'oVs6tsnU')
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
│   │   │   │       ├── T(DATA|'9Y9uFDwu')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'fiber ')
│   │   │       │   └── tag
│   │   │       │       ├── T(LEFT_ARROW|'<')
│   │   │       │       ├── T(DATA|'PALnQoTQ')
│   │   │       │       └── T(RIGHT_ARROW|'> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(RIGHT_ARROW|'>\r\n\r\n        ')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'what ')
│   │   │       │   │   │   └── tag
│   │   │       │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │       │   │   │       ├── T(DATA|'6hlYVfaz')
│   │   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'not ')
│   │   │       │       └── tag
│   │   │       │           ├── T(LEFT_ARROW|'<')
│   │   │       │           ├── T(DATA|'gubSBEDe')
│   │   │       │           └── T(RIGHT_ARROW|'>')
│   │   │       └── T(TERMINATOR|';\r\n\r\n\t')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'somth else ')
│   │       └── tag
│   │           ├── T(LEFT_ARROW|'<')
│   │           ├── T(DATA|'hAyLdw3m')
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')